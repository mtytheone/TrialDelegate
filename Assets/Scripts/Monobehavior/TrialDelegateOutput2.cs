using UnityEngine;

namespace Hatuxes.TrialDelegate
{
    public class TrialDelegateOutput2 : MonoBehaviour
    {

        void Start()
        {
            var test = new Test2();
            test.Delegate = () =>
            {
                Debug.Log(Random.Range(0, 5));
            };

            test.Delegate += () => Debug.Log(Random.Range(6, 12));

            test.Method();
        }
    }
}