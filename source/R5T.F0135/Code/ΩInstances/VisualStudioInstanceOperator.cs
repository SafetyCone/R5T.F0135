using System;


namespace R5T.F0135
{
    public class VisualStudioInstanceOperator : IVisualStudioInstanceOperator
    {
        #region Infrastructure

        public static IVisualStudioInstanceOperator Instance { get; } = new VisualStudioInstanceOperator();


        private VisualStudioInstanceOperator()
        {
        }

        #endregion
    }
}
