
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace RefreshRepro
{
    public static class Static_
	    {
        public const string BtnState_Comp1 = "Comp1";
        public const string BtnState_Start = "Start";

        public enum IBType
            {
            Checkbox1,
            }

        public static List<IBSpec> IBSpecList { get; set; }
        public static string BtnState { get; set; }

        public static int cantInspect;

        ///////////////
        //  Refresh  //
        ///////////////

        // This code invokes a method in the "Input Box" (IB) child components to get then to invoke StateHasChanged

        private static List<string> Refresh_Subscribers = new List<string>();
        private static event EventHandler Refresh_Event;

        //  Adds an event listener once and only once
        public static void Refresh_Subscribe(EventHandler newSubscriber, string subscriberName)
            {
            if (Refresh_Subscribers.Contains(subscriberName)) return;

            Refresh_Subscribers.Add(subscriberName);
            Refresh_Event += newSubscriber;
            }

        public static void Refresh_Throw(bool refreshCBB)
            {
            Console.WriteLine(string.Format("\nStatic.Refresh_Throw: Subscribers = {0}", Refresh_Subscribers.Count));

            if (refreshCBB && Refresh_Subscribers.Count > 0) Refresh_Event?.Invoke(null, null);
            
            } 
        }
}
