using System;


namespace R5T.F0135
{
    public class MSBuildLocatorOperator : IMSBuildLocatorOperator
    {
        #region Infrastructure

        public static IMSBuildLocatorOperator Instance { get; } = new MSBuildLocatorOperator();


        private MSBuildLocatorOperator()
        {
        }

        #endregion
    }
}
