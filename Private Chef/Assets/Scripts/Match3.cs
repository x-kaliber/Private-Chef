using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Match3 : MonoBehaviour
{
    public ArrayLayout boardLayout;
    public Sprite[] pieces;
    int width = 9;
    int height = 14;
    Node[,] board;

    System.Random random;

    void Start()
    {
        
    }

    void StartGame()
    {
        string seed = getRandomSeed();
        random = new System.Random(seed.GetHashCode());

        InitializeBoard();
    }

    void InitializeBoard()
    {
        board = new Node[width, height];
        for(int y = 0; y < height; y++)
        {
            for(int x = 0; x < width; x++)
            {
                board[x, y] = new Node((boardLayout.rows[y].row[x]) ? - 1 : fillPiece(), new Point(x, y));
            }
        }
    }

    void verifyBoard()
    {
        for (int x = 0; x < height; x++)
        {
            for (int y = 0; y < width; y++)
            {
                Point p = new Point(x, y);
                int val = getValuePoint(p);
                if (val <= 0) continue;

            }
        }
    }

    int fillPiece()
    {
        int val = 1;
        val = (random.Next(0, 100) / (100 / pieces.Length)) + 1;
        return val;
    }

    int getValuePoint(Point p)
    {
        return board[p.x, p.y].value;
    }

    void Update()
    {
        
    }

    string getRandomSeed()
    {
        string seed = "";
        string acceptableCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890!@£$%^&*()";
        for (int i = 0; i < 20; i++)
            seed += acceptableCharacters[Random.Range(0, acceptableCharacters.Length)];
        return seed;
    }
}
[System.Serializable]
public class Node
{
    public int value; //0 = blank, 1 = cube, 2 = sphere, 3 = cylinder, 4 = pyramid, -1 = hole
    public Point index;

    public Node(int v, Point i)
    {
        value = v;
        index = i;
    }
}