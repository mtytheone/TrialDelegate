using UnityEngine;

namespace Hatuxes.TrialDelegate
{
    public class TrialDelegateOutput1 : MonoBehaviour
    {

        void Start()
        {
            var test = new Test();
            Test.VoidNothingDelegate voidNothingDelegate = Callback;
            test.Method(voidNothingDelegate);
        }

        public void Callback()
        {
            Debug.Log("処理が終わったよー");
        }
    }
}