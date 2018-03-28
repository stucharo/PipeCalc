using System;
using System.Collections.Generic;

namespace PipeCalc
{
    public class Project
    {
        private ProjectSettings projectSettings;
        private List<Pipeline> Pipelines;
        private List<ProjectWorkflow> projectWorkflow;

        public Project()
        {
            projectSettings = new ProjectSettings();
            projectWorkflow = new List<ProjectWorkflow>();
        }
    }
}