using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libPods-Mixpanel.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64, 
	Frameworks = "Accelerate, CoreGraphics, CoreTelephony, Foundation, QuartzCore, SystemConfiguration, UIKit", 
	WeakFrameworks = "AdSupport", ForceLoad = true)]
