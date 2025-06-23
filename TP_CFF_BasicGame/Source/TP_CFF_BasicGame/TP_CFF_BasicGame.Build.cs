// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class TP_CFF_BasicGame : ModuleRules
{
	public TP_CFF_BasicGame(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"TP_CFF_BasicGame",
			"TP_CFF_BasicGame/Variant_Platforming",
			"TP_CFF_BasicGame/Variant_Combat",
			"TP_CFF_BasicGame/Variant_Combat/AI",
			"TP_CFF_BasicGame/Variant_SideScrolling",
			"TP_CFF_BasicGame/Variant_SideScrolling/Gameplay",
			"TP_CFF_BasicGame/Variant_SideScrolling/AI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
