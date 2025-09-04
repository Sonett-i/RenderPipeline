using UnityEngine;

[System.Serializable]
public class Face
{
	public int[] index = new int[3];

	public Face(int i, int j, int k)
	{
		index[0] = i;
		index[1] = j;
		index[2] = k;
	}
}
