using UnityEngine;

namespace Hatuxes.TrialDelegate
{
    public class TrialDelegateOutput4 : MonoBehaviour
    {
        void Start()
        {
            var test = new Test4(() => Debug.Log("処理した！"));
            test.Action();
        }
    }
}