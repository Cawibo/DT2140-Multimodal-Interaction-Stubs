using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Vuforia;

public class MyTrackableEventHandler : DefaultTrackableEventHandler
{

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
    }

}
