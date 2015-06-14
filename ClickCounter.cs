using System;
using Android.Runtime;

namespace CallMyJava {

	[global::Android.Runtime.Register ("com/companyname/callmyjava/ClickCounter", DoNotGenerateAcw=true)]
	public partial class ClickCounter : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/companyname/callmyjava/ClickCounter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ClickCounter); }
		}

		protected ClickCounter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;

		[Register (".ctor", "()V", "")]
		public unsafe ClickCounter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ClickCounter)) {
					SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_Clicked;
		#pragma warning disable 0169
		static Delegate GetClickedHandler ()
		{
			if (cb_Clicked == null)
				cb_Clicked = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Clicked);
			return cb_Clicked;
		}

		static int n_Clicked (IntPtr jnienv, IntPtr native__this)
		{
			global::CallMyJava.ClickCounter __this = global::Java.Lang.Object.GetObject<global::CallMyJava.ClickCounter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Clicked ();
		}
		#pragma warning restore 0169

		static IntPtr id_Clicked;

		[Register ("Clicked", "()I", "GetClickedHandler")]
		public virtual unsafe int Clicked ()
		{
			if (id_Clicked == IntPtr.Zero)
				id_Clicked = JNIEnv.GetMethodID (class_ref, "Clicked", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_Clicked);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Clicked", "()I"));
			} finally {
			}
		}

	}
}
