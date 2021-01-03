using System.Collections;
using UnityEngine;

#nullable enable
namespace Assets.Src.View.Entity
{
    /// <summary>
    /// �r���[����
    /// </summary>
    public abstract class ViewEntity : MonoBehaviour, IViewEntity
    {
        /// <summary>
        /// ���W�p�����[�^
        /// </summary>
        public ViewStateParameter<Vector2> coordinate { get; }
            = new ViewStateParameter<Vector2> { basis = Vector2.zero };
        /// <summary>
        /// �����x�p�����[�^
        /// </summary>
        public ViewStateParameter<float> alpha { get; }
            = new ViewStateParameter<float> { basis = 1f };
        /// <summary>
        /// �T�C�Y�{���p�����[�^
        /// </summary>
        public ViewStateParameter<Vector2> size { get; }
            = new ViewStateParameter<Vector2> { basis = Vector2.one };
        /// <summary>
        /// �w�ԍ��p�����[�^
        /// </summary>
        public ViewStateParameter<int> layer { get; }
            = new ViewStateParameter<int> { basis = 0 };
    }
}
