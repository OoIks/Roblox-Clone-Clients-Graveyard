// Lighting
public class Lighting : Instance
{
	public float secondsSinceMidnight;

	public Lighting()
		: base("Lighting")
	{
		secondsSinceMidnight = 46800f;
		bool flag = false;
		Instance[] children = GetChildren();
		for (int i = 0; i < children.Length; i++)
		{
			if (children[i].name == "Sun")
			{
				flag = true;
				break;
			}
			if (flag)
			{
				break;
			}
		}
		if (!flag)
		{
			AddChild(new Sun
			{
				secondsSinceMidnight = secondsSinceMidnight
			});
		}
	}
}
