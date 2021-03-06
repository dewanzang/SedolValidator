﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Sedol.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("SedolValidationCheck", Description="In order to ensure the functionality of Sedol check validator \r\nAs a user of the " +
        "website\r\nI want to input different data to esure is working as expected", SourceFile="Features\\SedolValidationCheck.feature", SourceLine=0)]
    public partial class SedolValidationCheckFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SedolValidationCheck.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SedolValidationCheck", "In order to ensure the functionality of Sedol check validator \r\nAs a user of the " +
                    "website\r\nI want to input different data to esure is working as expected", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void InputNullEmptyStringOrStringOtherThan7CharactersLong(string inputStringTestValue, string isValidSedol, string isUserDefined, string validationDetails, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Input Null, empty string or string other than 7 characters long", null, exampleTags);
#line 6
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
 testRunner.Given("User is at the Sedol Web App Home Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
    testRunner.When(string.Format("User enter InputString Test Value in Sedol input field {0}", inputStringTestValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
 testRunner.And(string.Format("Select Is Valid Sedol {0}", isValidSedol), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.And(string.Format("Select Is User Define {0}", isUserDefined), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.Then(string.Format("the correct Validation Details is displayed {0}", validationDetails), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Input Null, empty string or string other than 7 characters long, null", SourceLine=14)]
        public virtual void InputNullEmptyStringOrStringOtherThan7CharactersLong_Null()
        {
#line 6
this.InputNullEmptyStringOrStringOtherThan7CharactersLong("null", "false", "false", "\'Input string was not 7-characters long.\'", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Input Null, empty string or string other than 7 characters long, \"\"", SourceLine=14)]
        public virtual void InputNullEmptyStringOrStringOtherThan7CharactersLong_()
        {
#line 6
this.InputNullEmptyStringOrStringOtherThan7CharactersLong("\"\"", "false", "false", "\'Input string was not 7-characters long.\'", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Input Null, empty string or string other than 7 characters long, \'12\'", SourceLine=14)]
        public virtual void InputNullEmptyStringOrStringOtherThan7CharactersLong_12()
        {
#line 6
this.InputNullEmptyStringOrStringOtherThan7CharactersLong("\'12\'", "false", "false", "\'Input string was not 7-characters long.\'", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Input Null, empty string or string other than 7 characters long, \'123456789\'", SourceLine=14)]
        public virtual void InputNullEmptyStringOrStringOtherThan7CharactersLong_123456789()
        {
#line 6
this.InputNullEmptyStringOrStringOtherThan7CharactersLong("\'123456789\'", "false", "false", "\'Input string was not 7-characters long.\'", ((string[])(null)));
#line hidden
        }
        
        public virtual void InputInvalidNonUserDefineSEDOL(string inputStringTestValue, string isValidSedol, string isUserDefined, string validationDetails, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Input Invalid non user define SEDOL", null, exampleTags);
#line 22
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 23
 testRunner.Given("User is at the Sedol Web App Home Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 24
    testRunner.When(string.Format("User enter InputString Test Value in Sedol input field {0}", inputStringTestValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
 testRunner.And(string.Format("Select Is Valid Sedol {0}", isValidSedol), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.And(string.Format("Select Is User Define {0}", isUserDefined), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.Then(string.Format("the correct Validation Details is displayed {0}", validationDetails), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Input Invalid non user define SEDOL, \'1234567\'", SourceLine=30)]
        public virtual void InputInvalidNonUserDefineSEDOL_1234567()
        {
#line 22
this.InputInvalidNonUserDefineSEDOL("\'1234567\'", "false", "false", "\'Checksum digit does not agree with the rest of the input\'", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Input Invalid non user define SEDOL, \'ABCDEFG\'", SourceLine=30)]
        public virtual void InputInvalidNonUserDefineSEDOL_ABCDEFG()
        {
#line 22
this.InputInvalidNonUserDefineSEDOL("\'ABCDEFG\'", "false", "false", "\'Checksum digit does not agree with the rest of the input\'", ((string[])(null)));
#line hidden
        }
        
        public virtual void InputValidNonUserDefineSEDOL(string inputStringTestValue, string isValidSedol, string isUserDefined, string validationDetails, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Input Valid non user define SEDOL", null, exampleTags);
#line 34
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 35
 testRunner.Given("User is at the Sedol Web App Home Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 36
    testRunner.When(string.Format("User enter InputString Test Value in Sedol input field {0}", inputStringTestValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.And(string.Format("Select Is Valid Sedol {0}", isValidSedol), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And(string.Format("Select Is User Define {0}", isUserDefined), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.Then(string.Format("the correct Validation Details is displayed {0}", validationDetails), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Input Valid non user define SEDOL, \'0709954\'", SourceLine=42)]
        public virtual void InputValidNonUserDefineSEDOL_0709954()
        {
#line 34
this.InputValidNonUserDefineSEDOL("\'0709954\'", "true", "false", "", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Input Valid non user define SEDOL, \'B0YBKJ7\'", SourceLine=42)]
        public virtual void InputValidNonUserDefineSEDOL_B0YBKJ7()
        {
#line 34
this.InputValidNonUserDefineSEDOL("\'B0YBKJ7\'", "true", "false", "null", ((string[])(null)));
#line hidden
        }
        
        public virtual void InputInvalidUserDefinedSEDOL(string inputStringTestValue, string isValidSedol, string isUserDefined, string validationDetails, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Input Invalid user defined SEDOL", null, exampleTags);
#line 48
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 49
 testRunner.Given("User is at the Sedol Web App Home Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 50
    testRunner.When(string.Format("User enter InputString Test Value in Sedol input field {0}", inputStringTestValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
 testRunner.And(string.Format("Select Is Valid Sedol {0}", isValidSedol), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.And(string.Format("Select Is User Define {0}", isUserDefined), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.Then(string.Format("the correct Validation Details is displayed {0}", validationDetails), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Input Invalid user defined SEDOL, \'9123451\'", SourceLine=56)]
        public virtual void InputInvalidUserDefinedSEDOL_9123451()
        {
#line 48
this.InputInvalidUserDefinedSEDOL("\'9123451\'", "false", "true", "\'Checksum digit does not agree with the rest of the input\'", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Input Invalid user defined SEDOL, \'9ABCDE8\'", SourceLine=56)]
        public virtual void InputInvalidUserDefinedSEDOL_9ABCDE8()
        {
#line 48
this.InputInvalidUserDefinedSEDOL("\'9ABCDE8\'", "false", "true", "\'Checksum digit does not agree with the rest of the input\'", ((string[])(null)));
#line hidden
        }
        
        public virtual void InputValidUserDefinedSEDOL(string inputStringTestValue, string isValidSedol, string isUserDefined, string validationDetails, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Input Valid user defined SEDOL", null, exampleTags);
#line 60
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 61
 testRunner.Given("User is at the Sedol Web App Home Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 62
    testRunner.When(string.Format("User enter InputString Test Value in Sedol input field {0}", inputStringTestValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 63
 testRunner.And(string.Format("Select Is Valid Sedol {0}", isValidSedol), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
 testRunner.And(string.Format("Select Is User Define {0}", isUserDefined), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
 testRunner.Then(string.Format("the correct Validation Details is displayed {0}", validationDetails), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Input Valid user defined SEDOL, \'9123458\'", SourceLine=68)]
        public virtual void InputValidUserDefinedSEDOL_9123458()
        {
#line 60
this.InputValidUserDefinedSEDOL("\'9123458\'", "true", "true", "\'\'", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Input Valid user defined SEDOL, \'9ABCDE1\'", SourceLine=68)]
        public virtual void InputValidUserDefinedSEDOL_9ABCDE1()
        {
#line 60
this.InputValidUserDefinedSEDOL("\'9ABCDE1\'", "true", "true", "\'\'", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
