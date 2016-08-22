﻿/* 
 * Copyright (c) Microsoft Corporation. All rights reserved. Licensed under the MIT license.
 * See LICENSE in the project root for license information.
 */

using Microsoft.ResourceStaticAnalysis.Core.KnowledgeBase;

namespace Microsoft.ResourceStaticAnalysis.UnitTests.TestRules
{
    public class SampleRule3 : SampleRuleType
    {
        // Inherited constructor
        public SampleRule3(RuleManager rm) : base(rm)
        {
        }
        protected override void Run()
        {
            string message = "SourceString should not contain foo";
            Check(resource => !(resource.SourceString.Contains("foo")), ref message);
        }
    }
}
