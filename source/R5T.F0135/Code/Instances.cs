using System;


namespace R5T.F0135
{
    public static class Instances
    {
        public static F0000.IActionOperator ActionOperator => F0000.ActionOperator.Instance;
        public static F0000.IEnumerableOperator EnumerableOperator => F0000.EnumerableOperator.Instance;
        public static F0000.ITextOperator TextOperator => F0000.TextOperator.Instance;
        public static IVisualStudioInstanceQueryOptionsOperator VisualStudioInstanceQueryOptionsOperator => F0135.VisualStudioInstanceQueryOptionsOperator.Instance;
    }
}