using Castle.DynamicProxy;

namespace Core.Utilities.Interceptors
{
    public abstract class MethodInterception : MethodInterceptionBaseAttribute
    {
        #region Public Methods

        public override void Intercept(IInvocation invocation)
        {
            var isSuccess = true;
            OnBefore(invocation);
            try
            {
                invocation.Proceed();
            }
            catch (Exception e)
            {
                isSuccess = false;
                OnException(invocation, e);
                throw;
            }
            finally
            {
                if (isSuccess)
                {
                    OnSuccess(invocation);
                }
            }
            OnAfter(invocation);
        }

        #endregion Public Methods



        #region Protected Methods

        protected virtual void OnAfter(IInvocation invocation)
        { }

        //invocation :  business method
        protected virtual void OnBefore(IInvocation invocation)
        { }

        protected virtual void OnException(IInvocation invocation, System.Exception e)
        { }

        protected virtual void OnSuccess(IInvocation invocation)
        { }

        #endregion Protected Methods
    }
}