using System;
using UnityEngine;

namespace Hatuxes.TrialDelegate
{
    public class Test
    {
        public delegate void VoidNothingDelegate();

        public void Method(VoidNothingDelegate delegateMethod)
        {
            Debug.Log("処理中～");

            delegateMethod();
        }
    }

    public class Test2
    {
        public delegate void VoidNothingDelegate();
        public VoidNothingDelegate Delegate;

        public void Method()
        {
            Debug.Log("処理中～");

            Delegate();
        }
    }

    public class Test3
    {
        public Action Action { get; set; }

        public Test3(Action action)
        {
            Action = action;
        }

        public void Method()
        {
            Debug.Log("処理中～");

            Action();
        }
    }

    public class Test4
    {
        public Action Action { get; private set; }

        public Test4(Action action)
        {
            Action = action;
        }
    }

    public class Test5
    {
        private Action _action;

        public Test5(Action listener)
        {
            _action = listener;
        }

        public void Method()
        {
            Debug.Log("処理開始");

            Debug.Log(UnityEngine.Random.Range(0, 5));

            Debug.Log("処理終了");

            _action();
        }
    }
}