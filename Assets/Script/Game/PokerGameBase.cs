using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Poker;

public abstract class PokerGameBase
{
    // 算分
    public abstract int GetScore( List<Card> iHandCards);
}