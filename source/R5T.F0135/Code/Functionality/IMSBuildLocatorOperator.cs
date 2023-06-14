using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.Build.Locator;

using R5T.T0132;


namespace R5T.F0135
{
    [FunctionalityMarker]
    public partial interface IMSBuildLocatorOperator : IFunctionalityMarker
    {
        public IEnumerable<VisualStudioInstance> Find_VisualStudioInstances(VisualStudioInstanceQueryOptions options)
        {
            var output = MSBuildLocator.QueryVisualStudioInstances(options);
            return output;
        }

        public IEnumerable<VisualStudioInstance> Find_VisualStudioInstances()
        {
            var options = Instances.VisualStudioInstanceQueryOptionsOperator.Get_Default();

            var output = this.Find_VisualStudioInstances(options);
            return output;
        }

        public bool Is_Registered()
        {
            var output = MSBuildLocator.IsRegistered;
            return output;
        }

        public void In_RegisteredLocationContext(
            Action action = default)
        {
            this.Register_Defaults();

            Instances.ActionOperator.Run(action);

            this.Unregister();
        }

        public async Task In_RegisteredLocationContext(
            Func<Task> action = default)
        {
            this.Register_Defaults();

            await Instances.ActionOperator.Run(action);

            this.Unregister();
        }

        /// <summary>
        /// Tests for whether the locator is already registered before registering defaults.
        /// (This is required since registering a location if a location is already registered results in an exception.)
        /// </summary>
        public void Register_Defaults_IfNotAlreadyRegistered()
        {
            var isRegistered = this.Is_Registered();
            if(!isRegistered)
            {
                this.Register_Defaults_NonIdempotent();
            }
        }

        /// <summary>
        /// If <see cref="MSBuildLocator.RegisterDefaults"/> is called twice (or called while the locator is already registered) an exception occurs.
        /// </summary>
        public void Register_Defaults_NonIdempotent()
        {
            MSBuildLocator.RegisterDefaults();
        }

        /// <summary>
        /// Chooses <see cref="Register_Defaults_IfNotAlreadyRegistered"/> as the default behavior.
        /// </summary>
        public void Register_Defaults()
        {
            this.Register_Defaults_IfNotAlreadyRegistered();
        }

        public void Unregister()
        {
            MSBuildLocator.Unregister();
        }
    }
}
