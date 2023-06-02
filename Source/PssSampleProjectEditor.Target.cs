// Copyright 2023, Cheese Labs, All rights reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class PssSampleProjectEditorTarget : TargetRules
{
	public PssSampleProjectEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_1;
		ExtraModuleNames.Add("PssSampleProject");
	}
}
