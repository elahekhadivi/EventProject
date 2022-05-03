
		var number = new Number();
		number.number = 12;

		var noftify = new EvenNumber();
		noftify.EvenNumberHappend += number.HandleNotify;

		if(number.number%2 == 0)
        {
			noftify.Notify(number.number);
		}


public class Number
{
	public int number { get; set; }

	public void HandleNotify(object sender, EvenNumberEventArgs e)
	{
		Console.WriteLine($"{e.EvenNumber} is an even number");
	}

}


public class EvenNumber
{
	public event EvenNumberEventArgsHandeler EvenNumberHappend;

	public void Notify(int number)
	{
		Console.WriteLine("Alarm went off!");
		EvenNumberEventArgsHandeler notify = EvenNumberHappend;
		if (EvenNumberHappend != null)
		{
			notify(this, new EvenNumberEventArgs(number));
		}

	}
}


public delegate void EvenNumberEventArgsHandeler(object source, EvenNumberEventArgs e);



public class EvenNumberEventArgs : EventArgs
{
	public int EvenNumber { get; set; }
	public EvenNumberEventArgs(int evenNumber)
	{
		EvenNumber = evenNumber;

	}
}