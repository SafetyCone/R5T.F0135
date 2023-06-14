using System;


namespace R5T.F0135
{
    public class VisualStudioInstanceQueryOptionsOperator : IVisualStudioInstanceQueryOptionsOperator
    {
        #region Infrastructure

        public static IVisualStudioInstanceQueryOptionsOperator Instance { get; } = new VisualStudioInstanceQueryOptionsOperator();


        private VisualStudioInstanceQueryOptionsOperator()
        {
        }

        #endregion
    }
}
