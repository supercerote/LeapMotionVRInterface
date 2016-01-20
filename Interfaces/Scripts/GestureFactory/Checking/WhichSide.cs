﻿using UnityEngine;
using System.Collections;
using Leap;

public static class WhichSide{

	public static bool capturedSide(Hand hand, int useSide, bool isHeadMount)
    {
        if (!isHeadMount)
        {
            Vector position = hand.PalmPosition;
            Vector3 unityPosition = position.ToUnity();
            Vector3 toPos = new Vector3(((unityPosition.x + 150.0f) / 300.0f), (unityPosition.y / 300.0f), ((unityPosition.z + 150.0f) / 300.0f));
            Vector3 pos = Camera.main.ViewportToWorldPoint(toPos);
            Vector3 tempos = Camera.main.WorldToViewportPoint(pos);

            switch (useSide)
            {
                case 0:
                    return true;
                case 1:
                    if (tempos.x < 0.5 && tempos.x >= 0 && tempos.y >= 0 && tempos.y <= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case 2:
                    if (tempos.x > 0.5 && tempos.x <= 1 && tempos.y >= 0 && tempos.y <= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case 3:
                    if (tempos.y > 0.5 && tempos.y <= 1 && tempos.x >= 0 && tempos.x <= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case 4:
                    if (tempos.y < 0.5 && tempos.y >= 0 && tempos.x >= 0 && tempos.x <= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                default:
                    return false;
            }
        }
        // left, right : x, up,down : z
        else
        {
            Vector position = hand.PalmPosition;
            Vector3 unityPosition = position.ToUnity();
            Vector3 toPos = new Vector3(1 - ((unityPosition.x + 150.0f) / 300.0f), ((unityPosition.z + 150.0f) / 300.0f), (unityPosition.y / 300.0f));
            Vector3 pos = Camera.main.ViewportToWorldPoint(toPos);
            Vector3 tempos = Camera.main.WorldToViewportPoint(pos);

            switch (useSide)
            {
                case 0:
                    return true;
                case 1:
                    if (tempos.x < 0.5 && tempos.x >= 0 && tempos.y >= 0 && tempos.y <= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case 2:
                    if (tempos.x > 0.5 && tempos.x <= 1 && tempos.y >= 0 && tempos.y <= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case 3:
                    if (tempos.y > 0.5 && tempos.y <= 1 && tempos.x >= 0 && tempos.x <= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case 4:
                    if (tempos.y < 0.5 && tempos.y >= 0 && tempos.x >= 0 && tempos.x <= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                default:
                    return false;
            }
        }
    }

}