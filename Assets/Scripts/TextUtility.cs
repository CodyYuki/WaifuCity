using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class TextUtility : MonoBehaviour
{
    static public string ConvertSecondsToTimeDisplayString(float seconds, int hundredthsFontSize, string divider, string decimalDivider)
    {
        seconds += 0.00001f;

        int timeTotalSeconds = (int)seconds;
        int timeTotalMinutes = timeTotalSeconds / 60;
        int timeTotalHours = timeTotalMinutes / 60;

        // These are truncated down.
        int timeDisplayHundredths = (int)((seconds - (float)timeTotalSeconds) * 100.0f);
        int timeDisplaySeconds = timeTotalSeconds - (timeTotalMinutes * 60);
        int timeDisplayMinutes = timeTotalMinutes - (timeTotalHours * 60);
        int timeDisplayHours = timeTotalHours;

        StringBuilder resultBuilder = new StringBuilder();

        // Hours.
        if (timeTotalHours >= 1)
        {
            resultBuilder.Append(timeDisplayHours);
            resultBuilder.Append(divider);
        }

        // Minutes.
        if (timeTotalMinutes >= 1)
        {
            if (timeDisplayHours >= 1 && timeDisplayMinutes < 10)
            {
                resultBuilder.Append("0");
            }
            resultBuilder.Append(timeDisplayMinutes);
            resultBuilder.Append(divider);
        }

        // Seconds.
        if (timeDisplayMinutes >= 1 && timeDisplaySeconds < 10)
        {
            resultBuilder.Append("0");
        }
        resultBuilder.Append(timeDisplaySeconds);

        // Hundredths.
        resultBuilder.Append(decimalDivider);
        if (hundredthsFontSize >= 1)
        {
            resultBuilder.Append("<size=");
            resultBuilder.Append(hundredthsFontSize);
            resultBuilder.Append(">");
        }

        if (timeDisplayHundredths < 10)
        {
            resultBuilder.Append("0");
        }
        resultBuilder.Append(timeDisplayHundredths);

        if (hundredthsFontSize >= 1)
        {
            resultBuilder.Append("</size>");
        }

        return resultBuilder.ToString();
    }
}