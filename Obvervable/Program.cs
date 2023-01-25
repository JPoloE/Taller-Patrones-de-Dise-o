
using Obvervable.Implements;

Console.WriteLine("Hello, World!");


Polleria polleria =  new Polleria();

Jesus jesus = new Jesus(polleria);
Olga olga = new Olga(polleria);


var timer = new PeriodicTimer(TimeSpan.FromSeconds(2));

int i = 0;
while (await timer.WaitForNextTickAsync())
{

    polleria.hayPollito(i);
    i++;

    if (i > 4) {
        jesus.eliminarSuscripcion();
    }

}