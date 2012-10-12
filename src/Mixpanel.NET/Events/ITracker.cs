using System.Collections.Generic;
using System;

namespace Mixpanel.NET.Events
{
  public interface IEventTracker {
    bool Track(string @event, IDictionary<string, object> properties, Action<TrackResult> callback = null);
    bool Track(MixpanelEvent @event, Action<TrackResult> callback = null);
    bool Track<T>(T @event, Action<TrackResult> callback = null);
  }
}