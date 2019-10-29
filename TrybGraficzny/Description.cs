using System;
using System.Windows.Forms;

namespace TrybGraficzny
{
    public partial class Description : UserControl
    {
        SubmitCallback Callback;

        public delegate void SubmitCallback(bool resetgame);

        public Description(SubmitCallback fn)
        {
            Callback = fn;
            InitializeComponent();

            txtDescription.Text =
@"Instrukcja obsługi robota:

Cel robota jest każdorazowo losowany w taki sposób aby mógł być na całej planszy

Wybierz cel klikając w miejsce do którego ma iść robot, pamiętaj że robot potrafi chodzić tylko po prostych

Aktualny ruch zostanie zaznaczony odpowiednim znacznikiem, możesz wielokrotnie zmieniać cel następnego ruchu

Jeżeli nie masz pomysłu na ruch możesz użyć pomocy super zaawansowanego systemu AI (przycisk „Pomoc AI”)

Aby wykonać ruch kliknij przycisk „Start”

Opis kontrolek:
Kierunek - aktualny kierunek strzałka wskazuje w którą stronę ustawiony jest robot
Pozycja – położenie względem pozycji startowej opisana za pomocą standardowego układu kartezjańskiego
Do celu – w jakiej odległości (w linii prostej!) znajduje się cel
Ilość energii – ile energii pozostało w robocie, jeżeli ilość energii spadnie do 0 a cel nie zostanie odnaleziony a misja musi zacząć się od nowa
Krok – ruch jaki zostanie wykonany przez robota jako następny, strzałka wskazuje relatywny kierunek ruchu robota wzglądem jego aktualnego kierunku (strzałka w górę robot idzie w kierunku w którym jest ustawiony)
Licznik ruchów – ile ruchów wykonał robot";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Callback?.Invoke(false);
        }
    }
}
