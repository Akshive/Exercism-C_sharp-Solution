using System;

public class CircularBuffer<T>
{
    T[] Arr;

    int st, en, cnt, size;
    public CircularBuffer(int capacity)
    {
        size = capacity;
        Arr = new T[capacity];
        st =  en = cnt = 0;
    }

    public T Read()
    {
        if(cnt == 0)throw new InvalidOperationException();
        cnt--;
        st = (st+1)%size;
        return Arr[st];
    }

    public void Write(T value)
    {
        if(cnt == size)throw new InvalidOperationException();
        cnt++;
        en = (en+1)%size;
        Arr[en] = value;
    }

    public void Overwrite(T value)
    {
        if(cnt < size)this.Write(value);
        else{
            this.Clear();
            this.Write(value);
        }
    }

    public void Clear()
    {
        if(cnt == 0)return;
        cnt--;
        st = (st+1)%size;   
    }
}