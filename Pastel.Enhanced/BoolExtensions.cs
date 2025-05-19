using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Pastel;

public static class BoolExtensions
{
    /// <summary>
    /// Returns a string wrapped in an ANSI foreground color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="bool"/> value to color.</param>
    /// <param name="color">The color to use on the specified string.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Pastel(this bool value, Color color)
    {
        return value.ToString().Pastel(color);
    }

    /// <summary>
    /// Returns a string wrapped in an ANSI foreground color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="bool"/> value to color.</param>
    /// <param name="color">The color to use on the specified string.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Pastel(this bool value, ConsoleColor color)
    {
        return value.ToString().Pastel(color);
    }

    /// <summary>
    /// Returns a string wrapped in an ANSI foreground color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="bool"/> value to color.</param>
    /// <param name="hexColor">The color to use on the specified string.<para>Supported format: [#]RRGGBB (case-insensitive).</para></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Pastel(this bool value, in string hexColor)
    {
        return value.ToString().Pastel(hexColor);
    }

    /// <summary>
    /// Returns a string wrapped in an ANSI foreground color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="bool"/> value to color.</param>
    /// <param name="hexColor">The color to use on the specified string.<para>Supported format: [#]RRGGBB (case-insensitive).</para></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Pastel(this bool value, in ReadOnlySpan<char> hexColor)
    {
        return value.ToString().Pastel(hexColor);
    }



    /// <summary>
    /// Returns a string wrapped in an ANSI foreground color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="bool"/> value to color.</param>
    /// <param name="color">The color to use on the specified string.</param>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Pastel(this bool value, Color color, IFormatProvider? provider)
    {
        return value.ToString(provider).Pastel(color);
    }

    /// <summary>
    /// Returns a string wrapped in an ANSI foreground color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="bool"/> value to color.</param>
    /// <param name="color">The color to use on the specified string.</param>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Pastel(this bool value, ConsoleColor color, IFormatProvider? provider)
    {
        return value.ToString(provider).Pastel(color);
    }

    /// <summary>
    /// Returns a string wrapped in an ANSI foreground color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="bool"/> value to color.</param>
    /// <param name="hexColor">The color to use on the specified string.<para>Supported format: [#]RRGGBB (case-insensitive).</para></param>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Pastel(this bool value, in string hexColor, IFormatProvider? provider)
    {
        return value.ToString(provider).Pastel(hexColor);
    }

    /// <summary>
    /// Returns a string wrapped in an ANSI foreground color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="bool"/> value to color.</param>
    /// <param name="hexColor">The color to use on the specified string.<para>Supported format: [#]RRGGBB (case-insensitive).</para></param>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Pastel(this bool value, in ReadOnlySpan<char> hexColor, IFormatProvider? provider)
    {
        return value.ToString(provider).Pastel(hexColor);
    }



    /// <summary>
    /// Returns a string wrapped in an ANSI background color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="bool"/> value to color.</param>
    /// <param name="color">The color to use on the specified string.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string PastelBg(this bool value, Color color)
    {
        return value.ToString().PastelBg(color);
    }

    /// <summary>
    /// Returns a string wrapped in an ANSI background color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="bool"/> value to color.</param>
    /// <param name="color">The color to use on the specified string.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string PastelBg(this bool value, ConsoleColor color)
    {
        return value.ToString().PastelBg(color);
    }

    /// <summary>
    /// Returns a string wrapped in an ANSI background color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="bool"/> value to color.</param>
    /// <param name="hexColor">The color to use on the specified string.<para>Supported format: [#]RRGGBB (case-insensitive).</para></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string PastelBg(this bool value, in string hexColor)
    {
        return value.ToString().PastelBg(hexColor);
    }

    /// <summary>
    /// Returns a string wrapped in an ANSI background color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="bool"/> value to color.</param>
    /// <param name="hexColor">The color to use on the specified string.<para>Supported format: [#]RRGGBB (case-insensitive).</para></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string PastelBg(this bool value, in ReadOnlySpan<char> hexColor)
    {
        return value.ToString().PastelBg(hexColor);
    }



    /// <summary>
    /// Returns a string wrapped in an ANSI background color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="bool"/> value to color.</param>
    /// <param name="color">The color to use on the specified string.</param>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string PastelBg(this bool value, Color color, IFormatProvider? provider)
    {
        return value.ToString(provider).PastelBg(color);
    }

    /// <summary>
    /// Returns a string wrapped in an ANSI background color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="bool"/> value to color.</param>
    /// <param name="color">The color to use on the specified string.</param>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string PastelBg(this bool value, ConsoleColor color, IFormatProvider? provider)
    {
        return value.ToString(provider).PastelBg(color);
    }

    /// <summary>
    /// Returns a string wrapped in an ANSI background color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="bool"/> value to color.</param>
    /// <param name="hexColor">The color to use on the specified string.<para>Supported format: [#]RRGGBB (case-insensitive).</para></param>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string PastelBg(this bool value, in string hexColor, IFormatProvider? provider)
    {
        return value.ToString(provider).PastelBg(hexColor);
    }

    /// <summary>
    /// Returns a string wrapped in an ANSI background color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="bool"/> value to color.</param>
    /// <param name="hexColor">The color to use on the specified string.<para>Supported format: [#]RRGGBB (case-insensitive).</para></param>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string PastelBg(this bool value, in ReadOnlySpan<char> hexColor, IFormatProvider? provider)
    {
        return value.ToString(provider).PastelBg(hexColor);
    }
}