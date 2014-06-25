using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Reflection;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace FirstWFProject
{
    partial class Workflow1
    {
        #region Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("", "")]
        private void InitializeComponent()
        {
            this.CanModifyActivities = true;
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference1 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference2 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference3 = new System.Workflow.Activities.Rules.RuleConditionReference();
            this.codeActivity3_changed = new System.Workflow.Activities.CodeActivity();
            this.codeActivity2 = new System.Workflow.Activities.CodeActivity();
            this.ifElseBranchActivity2 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity1_Renamed = new System.Workflow.Activities.IfElseBranchActivity();
            this.codeActivity3 = new System.Workflow.Activities.CodeActivity();
            this.ifElseActivity1 = new System.Workflow.Activities.IfElseActivity();
            this.codeActivity1 = new System.Workflow.Activities.CodeActivity();
            // 
            // codeActivity3_changed
            // 
            this.codeActivity3_changed.Name = "codeActivity3_changed";
            this.codeActivity3_changed.ExecuteCode += new System.EventHandler(this.codeActivity3_ExecuteCode);
            // 
            // codeActivity2
            // 
            this.codeActivity2.Name = "codeActivity2";
            this.codeActivity2.ExecuteCode += new System.EventHandler(this.codeActivity2_ExecuteCode);
            // 
            // ifElseBranchActivity2
            // 
            this.ifElseBranchActivity2.Activities.Add(this.codeActivity3_changed);
            ruleconditionreference1.ConditionName = "Condition2";
            this.ifElseBranchActivity2.Condition = ruleconditionreference1;
            this.ifElseBranchActivity2.Name = "ifElseBranchActivity2";
            // 
            // ifElseBranchActivity1_Renamed
            // 
            this.ifElseBranchActivity1_Renamed.Activities.Add(this.codeActivity2);
            ruleconditionreference2.ConditionName = "COndition1";
            this.ifElseBranchActivity1_Renamed.Condition = ruleconditionreference2;
            this.ifElseBranchActivity1_Renamed.Name = "ifElseBranchActivity1_Renamed";
            // 
            // codeActivity3
            // 
            this.codeActivity3.Name = "codeActivity3";
            this.codeActivity3.ExecuteCode += new System.EventHandler(this.codeActivity3_ExecuteCode);
            // 
            // ifElseActivity1
            // 
            this.ifElseActivity1.Activities.Add(this.ifElseBranchActivity1_Renamed);
            this.ifElseActivity1.Activities.Add(this.ifElseBranchActivity2);
            this.ifElseActivity1.Name = "ifElseActivity1";
            // 
            // codeActivity1
            // 
            this.codeActivity1.Name = "codeActivity1";
            this.codeActivity1.ExecuteCode += new System.EventHandler(this.codeActivity1_ExecuteCode);
            // 
            // Workflow1
            // 
            this.Activities.Add(this.codeActivity1);
            this.Activities.Add(this.ifElseActivity1);
            this.Activities.Add(this.codeActivity3);
            ruleconditionreference3.ConditionName = "Condition1";
            this.DynamicUpdateCondition = ruleconditionreference3;
            this.Name = "Workflow1";
            this.SetValue(System.Workflow.ComponentModel.WorkflowChanges.ConditionProperty, ruleconditionreference3);
            this.CanModifyActivities = false;

        }

        #endregion

        private CodeActivity codeActivity3;

        private IfElseBranchActivity ifElseBranchActivity2;

        private IfElseBranchActivity ifElseBranchActivity1_Renamed;

        private IfElseActivity ifElseActivity1;

        private CodeActivity codeActivity3_changed;

        private CodeActivity codeActivity2;

        private CodeActivity codeActivity1;










    }
}
