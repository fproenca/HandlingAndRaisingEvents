using System;

namespace Event
{
    public delegate void Event<TEventArgs>(object sender, TEventArgs e);

    public delegate void Event(object sender, EventArgs e);
}
