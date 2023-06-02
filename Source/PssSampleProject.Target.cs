// Copyright 2023, Cheese Labs, All rights reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class PssSampleProjectTarget : TargetRules
{
	public PssSampleProjectTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_1;
		ExtraModuleNames.Add("PssSampleProject");
	}
}
