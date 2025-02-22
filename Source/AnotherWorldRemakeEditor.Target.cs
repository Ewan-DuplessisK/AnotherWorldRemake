// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class AnotherWorldRemakeEditorTarget : TargetRules
{
	public AnotherWorldRemakeEditorTarget( TargetInfo Target) : base(Target)
	{
		bOverrideBuildEnvironment = true;
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V4;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_1;
		ExtraModuleNames.Add("AnotherWorldRemake");
	}
}
