using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Poker;

public class DemoGUI : MonoBehaviour
{
    private CardDeck nowCardDeck;
    private CardDeck nowHand;
    private Blackjack.BlackjackGameScore blackjackGameScore;

    private void Awake()
    {
        blackjackGameScore = new();
    }

    private void OnGUI()
    {
        Vector3 guiScale = Vector3.one * 2f;
        GUI.matrix = Matrix4x4.TRS( new Vector3(0, 0, 0), Quaternion.identity, guiScale );

        DrawGUI_Button();
        DrawGUI_Info();
    }

    private void DrawGUI_Button()
    {
        // Deck
        if( GUI.Button( new Rect( 0, 0, 150, 50 ), "Create Deck" ) )
        {
            nowCardDeck = new CardDeck();
            nowCardDeck.AddOneSetOfDeck();
            nowCardDeck.Debug_LogNowCards();
        }

        if( GUI.Button( new Rect( 0, 50, 150, 50 ), "Shuffle Deck" ) )
        {
            nowCardDeck?.Shuffle();
            nowCardDeck?.Debug_LogNowCards();
        }

        if( GUI.Button( new Rect( 0, 100, 150, 50 ), "Shuffle x1000 Test" ) )
        {
            nowCardDeck?.Shuffle( 1000 );
            nowCardDeck?.Debug_LogNowCards();
        }

        if( GUI.Button( new Rect( 0, 250, 150, 50 ), "Deal 1 To Hand" ) )
        {
            nowCardDeck?.DealCardFromTop( nowHand );
        }

        // Hand
        if( GUI.Button( new Rect( 150, 0, 150, 50 ), "Create Hand" ) )
        {
            nowHand = new CardDeck();
        }
    }

    private void DrawGUI_Info()
    {
        if( nowHand == null )
            return;

        // Hand
        string handInfo = "手牌資訊";
        for( int i = 0; i < nowHand.Cards.Count; i++ )
            handInfo += $"\n{ nowHand.Cards[ i ].CardInfo?.GetInfoStr() }";
        GUI.Label( new Rect( 450, 0, 150, 800 ), handInfo );

        // Blackjack Score
        int handScore_blackJack = blackjackGameScore.GetScore( nowHand.Cards );
        string handScoreInfo = $"手牌分數 (Blackjack) : { handScore_blackJack }";
        GUI.Label( new Rect( 650, 0, 150, 800 ), handScoreInfo );
    }
}