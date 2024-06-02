public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else if (Left.Contains(value) == false)
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else if (Right.Contains(value) == false)
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        if (value == Data)
        {
            return true;
        }

        if (value < Data)
        {
            if (Left is null)
            {
                return false;
            }

            else if (Left is not null)
            {
                if (Left.Data == value)
                {
                    return true;
                }
                else
                {
                    Left.Contains(value);
                }
            }
        }

        else if (value > Data)
        {
            if (Right is null)
            {
                return false;
            }

            else if (Right is not null)
            {
                if (Right.Data == value)
                {
                    return true;
                }
                else
                {
                    Right.Contains(value);
                }
            }
        }
        // TODO Start Problem 2
        return false;
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        return 0; // Replace this line with the correct return statement(s)
    }
}