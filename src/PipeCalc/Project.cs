using System;
using System.Collections.Generic;

namespace PipeCalc
{
    public class Project
    {
        private ProjectSettings projectSettings;
        private List<Pipeline> Pipelines;
        private List<ProjectWorkflow> projectWorkflows;
        private List<ProjectSolution> projectSolutions;

        public Project()
        {
            projectSettings = new ProjectSettings();
            projectWorkflows = new List<ProjectWorkflow>();
        }
    }
}