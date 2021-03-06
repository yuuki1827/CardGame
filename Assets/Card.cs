﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// カードのデータを保持するクラス
/// 数字・マーク・ジョーカー判定の3項目を持つ
/// </summary>
public class Card : MonoBehaviour
{
    /* カードのマーク */
    public int suit;

    /* カードの数字 */
    public int number;

    /* ジョーカー判定 */
    // Jokerの場合、マーク・数字に関係なくJoker扱いとする
    public bool isJoker;

    /* 各マークでの枚数を判定 */
    public const int numbersInSuit = 13;

    /* 各マークのIDを決める */
    //public const int Spade = 0;
    //public const int Club = 1;
    //public const int Heart = 2;
    //public const int Diamond = 3;
    public enum CardTypes
    {
        Club, Diamond, Heart, Spades
    }

    public Card(int suit, int number, bool isJoker)
    {
        this.suit = suit;
        this.number = number;
        this.isJoker = isJoker;
    }

    /// <summary>
    /// カードをめくる位置を設定する
    /// </summary>
    /// <param name="position">奥行きのポジション</param>
    public void CardOpen(float position)
    {
        transform.position = new Vector3(
            transform.position.x + 10f, transform.position.y, position);
        transform.rotation = Quaternion.Euler(
            transform.rotation.x + 90f, transform.rotation.y, transform.rotation.z - 180f);
    }

    /// <summary>
    /// カードをセットする位置を設定する
    /// </summary>
    /// <param name="position">奥行きのポジション</param>
    public void CardSet(float position)
    {
        transform.position = new Vector3(-5f, 0f, position);
        transform.rotation = Quaternion.Euler(-90f, 0f, 180f);
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }
}




