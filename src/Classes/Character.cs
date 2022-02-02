using System;

namespace harryPotter.src.Classes;

public class Character
{
    private int _id;
    private string _name;
    private int _magic;
    private int _cunning;
    private int _courage;
    private int _wisdom;
    private int _temper;
    private string _imgUrl;

    public int Id 
    {
        get => _id;
        set => _id = value;
    }
    public string Name 
    { 
        get => _name; 
        set => _name = value;
    }
    public int Magic 
    { 
        get => _magic; 
        set => _magic = value;
    }
    public int Cunning 
    { 
        get => _cunning;
        set => _cunning = value;
    }
    public int Courage 
    { 
        get => _courage; 
        set => _courage = value;
    }
    public int Wisdom 
    {
        get => _wisdom; 
        set => _wisdom = value;
    }
    public int Temper 
    {
        get => _temper;
        set => _temper = value;
    } 
    public string ImgUrl 
    {
        get => _imgUrl;
        set => _imgUrl = value;
    } 
}
