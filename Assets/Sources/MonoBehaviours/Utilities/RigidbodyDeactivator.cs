using System;
using UnityEngine;
using Photon.Pun;
namespace Sources.MonoBehaviours.Utilities
{
    /// <summary>
    /// Utility script that deactivate the rigidbody when it's not owned.
    /// </summary>
    public sealed class RigidbodyDeactivator : MonoBehaviour
    {
        private Rigidbody _rigidbody;
        private PhotonView _photonView;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _photonView = GetComponent<PhotonView>();
        }

        private void Start()
        {
            if (!_photonView.IsMine)
            {
                _rigidbody.isKinematic = true;
            }
        }
    }
}
