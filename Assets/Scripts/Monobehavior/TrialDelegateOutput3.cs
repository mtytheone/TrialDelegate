using UnityEngine;

namespace Hatuxes.TrialDelegate
{
    public class TrialDelegateOutput3 : MonoBehaviour
    {
        void Start()
        {
            var test = new Test3(() => Debug.Log("一つ目の処理"));

            test.Action += () => Debug.Log("二つ目の処理");
            test.Action += () => Debug.Log("三つ目の処理");

            test.Action();
        }
    }
}