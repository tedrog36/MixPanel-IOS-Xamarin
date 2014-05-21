using System;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;

namespace MixpanelAPI
{
	[BaseType (typeof (NSObject))]
	public partial interface Mixpanel {

		[Export ("people", ArgumentSemantic.Retain)]
		MixpanelPeople People { get; }

		[Export ("distinctId", ArgumentSemantic.Copy)]
		string DistinctId { get; }

		[Export ("nameTag", ArgumentSemantic.Copy)]
		string NameTag { get; set; }

		[Export ("serverURL", ArgumentSemantic.Copy)]
		string ServerURL { get; set; }

		[Export ("flushInterval")]
		uint FlushInterval { get; set; }

		[Export ("flushOnBackground")]
		bool FlushOnBackground { get; set; }

		[Export ("showNetworkActivityIndicator")]
		bool ShowNetworkActivityIndicator { get; set; }

		[Export ("checkForSurveysOnActive")]
		bool CheckForSurveysOnActive { get; set; }

		[Export ("showSurveyOnActive")]
		bool ShowSurveyOnActive { get; set; }

		[Export ("checkForNotificationsOnActive")]
		bool CheckForNotificationsOnActive { get; set; }

		[Export ("showNotificationOnActive")]
		bool ShowNotificationOnActive { get; set; }

		[Export ("delegate", ArgumentSemantic.Assign)]
		MixpanelDelegate Delegate { get; set; }

		[Static, Export ("sharedInstanceWithToken:")]
		Mixpanel SharedInstanceWithToken (string apiToken);

		[Static, Export ("sharedInstance")]
		Mixpanel SharedInstance { get; }

		[Export ("initWithToken:andFlushInterval:")]
		IntPtr Constructor (string apiToken, uint flushInterval);

		[Export ("identify:")]
		void Identify (string distinctId);

		[Export ("track:")]
		void Track (string theEvent);

		[Export ("track:properties:")]
		void Track (string theEvent, NSDictionary properties);

		[Export ("registerSuperProperties:")]
		void RegisterSuperProperties (NSDictionary properties);

		[Export ("registerSuperPropertiesOnce:")]
		void RegisterSuperPropertiesOnce (NSDictionary properties);

		[Export ("registerSuperPropertiesOnce:defaultValue:")]
		void RegisterSuperPropertiesOnce (NSDictionary properties, NSObject defaultValue);

		[Export ("unregisterSuperProperty:")]
		void UnregisterSuperProperty (string propertyName);

		[Export ("clearSuperProperties")]
		void ClearSuperProperties ();

		[Export ("currentSuperProperties")]
		NSDictionary CurrentSuperProperties { get; }

		[Export ("reset")]
		void Reset ();

		[Export ("flush")]
		void Flush ();

		[Export ("archive")]
		void Archive ();

		[Export ("showSurveyWithID:")]
		void ShowSurveyWithID (uint ID);

		[Export ("showSurvey")]
		void ShowSurvey ();

		[Export ("showNotificationWithID:")]
		void ShowNotificationWithID (uint ID);

		[Export ("showNotificationWithType:")]
		void ShowNotificationWithType (string type);

		[Export ("showNotification")]
		void ShowNotification ();

		[Export ("createAlias:forDistinctID:")]
		void CreateAlias (string alias, string distinctID);
	}

	[BaseType (typeof (NSObject))]
	public partial interface MixpanelPeople {

		[Export ("addPushDeviceToken:")]
		void AddPushDeviceToken (NSData deviceToken);

		[Export ("set:")]
		NSDictionary Set (NSDictionary properties);

		[Export ("set:to:")]
		void Set (string property, NSObject value);

		[Export ("setOnce:")]
		NSDictionary SetOnce (NSDictionary properties);

		[Export ("increment:")]
		void Increment (NSDictionary properties);

		[Export ("increment:by:")]
		void Increment (string property, NSNumber amount);

		[Export ("append:")]
		void Append (NSDictionary properties);

		[Export ("union:")]
		void Union (NSDictionary properties);

		[Export ("trackCharge:")]
		void TrackCharge (NSNumber amount);

		[Export ("trackCharge:withProperties:")]
		void TrackCharge (NSNumber amount, NSDictionary properties);

		[Export ("clearCharges")]
		void ClearCharges ();

		[Export ("deleteUser")]
		void DeleteUser ();
	}

	[Model, BaseType (typeof (NSObject))]
	public partial interface MixpanelDelegate {

		[Export ("mixpanelWillFlush:")]
		bool  MixpanelWillFlush(Mixpanel mixpanel);
	}
}
