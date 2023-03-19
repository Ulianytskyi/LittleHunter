using System;
using UnityEngine;

namespace Sources.MonoBehaviours
{
    public sealed class PreBoostrap : MonoBehaviour
    {
        [SerializeField]
        private GameObject splashScene;

        private void Awake()
        {
            BootstrapStart();
        }

        private void BootstrapStart()
        {
            splashScene.SetActive(true);
            gameObject.SetActive(true);
        }
    }
}
