// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class KeepClimbing : ModuleRules
{
	public KeepClimbing(ReadOnlyTargetRules Target) : base(Target)
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
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"KeepClimbing",
			"KeepClimbing/Variant_Platforming",
			"KeepClimbing/Variant_Platforming/Animation",
			"KeepClimbing/Variant_Combat",
			"KeepClimbing/Variant_Combat/AI",
			"KeepClimbing/Variant_Combat/Animation",
			"KeepClimbing/Variant_Combat/Gameplay",
			"KeepClimbing/Variant_Combat/Interfaces",
			"KeepClimbing/Variant_Combat/UI",
			"KeepClimbing/Variant_SideScrolling",
			"KeepClimbing/Variant_SideScrolling/AI",
			"KeepClimbing/Variant_SideScrolling/Gameplay",
			"KeepClimbing/Variant_SideScrolling/Interfaces",
			"KeepClimbing/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
