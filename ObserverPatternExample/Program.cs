// See https://aka.ms/new-console-template for more information

using ObserverPatternExample;

var chat = new Chat();

var client1 = new ChatClient( "client1");


var client2 = new ChatClient( "client2");


var client3 = new ChatClient( "client3");


/*Example Add Observers for pattern
 chat.Add(client1);
chat.Add(client2);
chat.Add(client3);*/

chat.SendMessage(new Message()
{
 Sender = client1.DisplayName,
 Text = "Привет!"
});

chat.SendMessage(new Message()
{
 Sender = client2.DisplayName,
 Text = "Как у вас дела?"
});

chat.SendMessage(new Message()
{
 Sender = client3.DisplayName,
 Text = "Нормально!"
});

chat.NewMessageEvent += client1.NotifyChange;
chat.NewMessageEvent += client2.NotifyChange;
chat.NewMessageEvent += client3.NotifyChange;

chat.NewMessageEvent -= (m) =>
{
Console.WriteLine(m.Text);
}; 
