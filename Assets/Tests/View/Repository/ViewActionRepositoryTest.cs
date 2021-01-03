using Assets.Src.Model.Application.Value;
using Assets.Src.View.Entity;
using Assets.Tests;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Src.View.Repository.Test
{
    public static class ViewActionRepositoryTest
    {
        [Test]
        public static void SetActionTest_()
        {
            var entityRepositoryMock = new Mock<IViewEntityRepository>();
            var key = Mock.Of<IViewKey>();
            var keyEmpty = Mock.Of<IViewKey>();
            var entityMock = new Mock<IViewEntity>();
            var coordinateBasis = new Vector2(1, 6.5f);
            var coordinate = new ViewStateParameter<Vector2> { basis = coordinateBasis };
            entityMock.SetupGet(mock => mock.coordinate).Returns(coordinate);
            var alphaBasis = 32.66f;
            var alpha = new ViewStateParameter<float> { basis = alphaBasis };
            entityMock.SetupGet(mock => mock.alpha).Returns(alpha);
            var sizeBasis = Vector2.one;
            var size = new ViewStateParameter<Vector2> { basis = sizeBasis };
            entityMock.SetupGet(mock => mock.size).Returns(size);
            var layerBasis = 136;
            var layerProgresses = new[] { (new Easing(Easing.Pattern.Linear, Easing.Bias.Out), 5, 12) };
            var layer = new ViewStateParameter<int> { basis = layerBasis, progresses = layerProgresses };
            entityMock.SetupGet(mock => mock.layer).Returns(layer);
            var entity = entityMock.Object;
            var entityEmptyMock = new Mock<IViewEntity>();
            entityEmptyMock
                .SetupGet(mock => mock.coordinate)
                .Throws(new NotImplementedException(nameof(IViewEntity.coordinate)));
            entityEmptyMock
                .SetupGet(mock => mock.alpha)
                .Throws(new NotImplementedException(nameof(IViewEntity.alpha)));
            entityEmptyMock
                .SetupGet(mock => mock.size)
                .Throws(new NotImplementedException(nameof(IViewEntity.size)));
            entityEmptyMock
                .SetupGet(mock => mock.layer)
                .Throws(new NotImplementedException(nameof(IViewEntity.layer)));
            var entityEmpty = entityEmptyMock.Object;
            entityRepositoryMock
                .Setup(mock => mock.GetEntity(It.IsAny<IViewKey>()))
                .Throws<KeyNotFoundException>();
            entityRepositoryMock.Setup(mock => mock.GetEntity(key)).Returns(entity);
            entityRepositoryMock.Setup(mock => mock.GetEntity(keyEmpty)).Returns(entityEmpty);
            var entityRepository = entityRepositoryMock.Object;
            var repository = new ViewActionRepository(entityRepository);
            var keyNew = Mock.Of<IViewKey>();
            var shape = new ViewShape(0.8f, new Vector2(4, -0.6f), 3);
            var shapeNew = new ViewShape(3.8f, new Vector2(-7, 125.6f), 16);
            var viewList = new (IViewKey, ViewShape)[] { (key, shape), (keyNew, shapeNew) };
            var layoutMock = new Mock<IViewLayout>();
            layoutMock.SetupGet(mock => mock.coordinate).Returns(new Vector2(1, 3));
            layoutMock.SetupGet(mock => mock.pivot).Returns(SpriteAlignment.Center);
            layoutMock.SetupGet(mock => mock.angle).Returns(10.3f);
            var yConst = 10.2f;
            layoutMock
                .Setup(mock => mock.GetPositionMap(It.IsAny<IList<IViewKey>>()))
                .Returns<IList<IViewKey>>(_viewList => _viewList
                    .Select((view, index) => (view, index))
                    .ToDictionary(pair => pair.view, pair => new Vector2(pair.index, yConst)));
            var layout = layoutMock.Object;
            var easing = new Easing(Easing.Pattern.Circular, Easing.Bias.In);
            var willBeDestroyed = true;
            var action = new ViewAction(viewList, layout, easing, willBeDestroyed);

            repository.SetAction(action);

            {
                var result = entity.coordinate;
                result.IsNotNull();
                result.basis.Is(coordinateBasis);
                result.progresses.Count().Is(1);
                {
                    var (easingResult, timeResult, finalResult) = result.progresses.ToList()[0];
                    easingResult.pattern.Is(easing.pattern);
                    easingResult.bias.Is(easing.bias);
                    easingResult.isIncrease.Is(easing.isIncrease);
                    easingResult.timeRequired.Is(easing.timeRequired);
                    timeResult.Is(0);
                    finalResult.x.Is(0);
                    finalResult.y.Is(yConst);
                }
            }
            {
                var result = entity.alpha;
                result.IsNotNull();
                result.basis.Is(alphaBasis);
                result.progresses.Count().Is(1);
                {
                    var (easingResult, timeResult, finalResult) = result.progresses.ToList()[0];
                    easingResult.pattern.Is(easing.pattern);
                    easingResult.bias.Is(easing.bias);
                    easingResult.isIncrease.Is(easing.isIncrease);
                    easingResult.timeRequired.Is(easing.timeRequired);
                    timeResult.Is(0);
                    finalResult.Is((shape.alpha ?? throw new NullReferenceException(nameof(shape.alpha))) - alphaBasis);
                }
            }
            {
                var result = entity.size;
                result.IsNotNull();
                result.basis.Is(sizeBasis);
                result.progresses.Count().Is(1);
                {
                    var (easingResult, timeResult, finalResult) = result.progresses.ToList()[0];
                    easingResult.pattern.Is(easing.pattern);
                    easingResult.bias.Is(easing.bias);
                    easingResult.isIncrease.Is(easing.isIncrease);
                    easingResult.timeRequired.Is(easing.timeRequired);
                    timeResult.Is(0);
                    finalResult.Is((shape.size ?? throw new NullReferenceException(nameof(shape.size))) - sizeBasis);
                }
            }
            {
                var result = entity.layer;
                result.IsNotNull();
                result.basis.Is(layerBasis);
                result.progresses.Count().Is(1);
                {
                    var (easingResult, timeResult, finalResult) = result.progresses.ToList()[0];
                    easingResult.pattern.Is(easing.pattern);
                    easingResult.bias.Is(easing.bias);
                    easingResult.isIncrease.Is(easing.isIncrease);
                    easingResult.timeRequired.Is(easing.timeRequired);
                    timeResult.Is(0);
                    finalResult.Is((shape.layer ?? throw new NullReferenceException(nameof(shape.layer))) - layerBasis);
                }
            }
        }
    }
}
