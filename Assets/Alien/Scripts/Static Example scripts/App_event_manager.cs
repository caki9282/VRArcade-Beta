using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class App_event_manager
{
    public static readonly player_events Player = new player_events();
    public static readonly UI_events ui_events = new UI_events();

    //we will create 2 classes scoped within this calss
    public class player_events
    {
        public UnityAction<Component, int> On_health_changed;
    }

    public class UI_events
    {
        public UnityAction<Component, int> On_button_press;
    }
}
