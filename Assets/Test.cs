//Lesson4課題
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//発展課題：Bossクラスに、変数mpとMagic関数を作成
public class Boss
{
	//変数mpを宣言し、53で初期化
	private int mp = 53;

	//mpを消費して魔法攻撃をするMagic関数を作成
	public void Magic()
	{
		//条件分岐
		if (this.mp > 5)
		{
			/*MPが足りてる場合
			 mpを5減らし、コンソールに「魔法攻撃をした。残りMPは○○。」と表示*/
			this.mp -= 5;
			Debug.Log("魔法攻撃をした。残りのMPは" + this.mp + "。");
		}
		else
		{
			//MPが足りない場合
			Debug.Log("MPが足りないため魔法が使えない。");
		}
	}

}


public class Test : MonoBehaviour
{

	void Start()
	{
		// Bossクラスの変数を宣言
		Boss lastBoss = new Boss();

		//Magic関数を10回処理する
		for (int i = 0; i < 10; i++)
		{
			lastBoss.Magic();
		}

		//更にMagic関数を呼び出し、mpが足りないメッセージを表示
		lastBoss.Magic();

		//課題：配列を宣言して出力してみましょう
		//要素数5のint型の配列arrayを宣言し、値を初期化
		int[] array = { 1, 2, 3, 4, 5 };


		// for文を使い、配列の各要素の値を順番に表示
		for (int a = 0; a < array.Length; a++)
		{
			Debug.Log(array[a]);
		}

		//for文を使い、配列の各要素の値を逆順に表示
		for (int b = 4; b < array.Length; b--)
		{
			Debug.Log(array[b]);
		}


	}

	//Updeate is called once per frame
	private void FixedUpdate()
	{

	}
}
