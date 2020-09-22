using UnityEngine;

namespace Hatuxes.TrialDelegate
{
    public class TrialDelegateOutput5 : MonoBehaviour
    {
        [SerializeField]
        private GameObject _gameObject;

        void Start()
        {
            // Test5ではMonoBehaviorを継承してないからDestroyは直接使えないんだけど、
            // Delegateでコールバックすることにより、使えないはずの関数も処理できるようになっている。
            // （返り値と引数さえ等しければ何を入れても良いため）
            var test = new Test5(() => Destroy(_gameObject));

            test.Method();
        }
    }
}