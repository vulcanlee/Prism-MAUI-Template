using CommunityToolkit.Mvvm.Messaging.Messages;
using MauiApp1.Models;

namespace MauiApp1.Events;

public class MyValueChangedMessage : ValueChangedMessage<MyMessage>
{
    public MyValueChangedMessage(MyMessage myMessage) : base(myMessage)
    {
    }
}
