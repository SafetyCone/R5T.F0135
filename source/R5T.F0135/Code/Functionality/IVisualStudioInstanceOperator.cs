using System;
using System.Collections.Generic;
using System.IO;

using Microsoft.Build.Locator;

using R5T.T0132;


namespace R5T.F0135
{
    [FunctionalityMarker]
    public partial interface IVisualStudioInstanceOperator : IFunctionalityMarker
    {
        public string Describe_To_String(VisualStudioInstance visualStudioInstance)
        {
            var text = Instances.TextOperator.JoinLines(
                Instances.EnumerableOperator.From(
                    $"{visualStudioInstance.Name} ({visualStudioInstance.Version}):",
                    $"\t{visualStudioInstance.DiscoveryType}: Discovery type",
                    $"\t{visualStudioInstance.VisualStudioRootPath} (Visual Studio Root)",
                    $"\t{visualStudioInstance.MSBuildPath} (MSBuild)"
                )
            );

            return text;
        }

        public void Describe_To(
            VisualStudioInstance visualStudioInstance,
            TextWriter writer)
        {
            var text = this.Describe_To_String(visualStudioInstance);

            writer.WriteLine(text);
        }

        public void Describe_To(
            IEnumerable<VisualStudioInstance> visualStudioInstances,
            TextWriter writer)
        {
            foreach (var visualStudioInstance in visualStudioInstances)
            {
                this.Describe_To(
                    visualStudioInstance,
                    writer);

                writer.WriteLine();
            }
        }
    }
}
