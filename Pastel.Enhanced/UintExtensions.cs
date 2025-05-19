using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Pastel;

public static class UintExtensions
{
    /// <summary>
    /// Returns a string wrapped in an ANSI foreground color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="uint"/> value to color.</param>
    /// <param name="color">The color to use on the specified string.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Pastel(this uint value, Color color)
    {
        return value.ToString().Pastel(color);
    }

    /// <summary>
    /// Returns a string wrapped in an ANSI foreground color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="uint"/> value to color.</param>
    /// <param name="color">The color to use on the specified string.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Pastel(this uint value, ConsoleColor color)
    {
        return value.ToString().Pastel(color);
    }

    /// <summary>
    /// Returns a string wrapped in an ANSI foreground color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="uint"/> value to color.</param>
    /// <param name="hexColor">The color to use on the specified string.<para>Supported format: [#]RRGGBB (case-insensitive).</para></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Pastel(this uint value, in string hexColor)
    {
        return value.ToString().Pastel(hexColor);
    }

    /// <summary>
    /// Returns a string wrapped in an ANSI foreground color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="uint"/> value to color.</param>
    /// <param name="hexColor">The color to use on the specified string.<para>Supported format: [#]RRGGBB (case-insensitive).</para></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Pastel(this uint value, in ReadOnlySpan<char> hexColor)
    {
        return value.ToString().Pastel(hexColor);
    }



    /// <summary>
    /// Returns a string wrapped in an ANSI foreground color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="uint"/> value to color.</param>
    /// <param name="color">The color to use on the specified string.</param>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Pastel(this uint value, Color color, IFormatProvider? provider)
    {
        return value.ToString(provider).Pastel(color);
    }

    /// <summary>
    /// Returns a string wrapped in an ANSI foreground color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="uint"/> value to color.</param>
    /// <param name="color">The color to use on the specified string.</param>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Pastel(this uint value, ConsoleColor color, IFormatProvider? provider)
    {
        return value.ToString(provider).Pastel(color);
    }

    /// <summary>
    /// Returns a string wrapped in an ANSI foreground color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="uint"/> value to color.</param>
    /// <param name="hexColor">The color to use on the specified string.<para>Supported format: [#]RRGGBB (case-insensitive).</para></param>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Pastel(this uint value, in string hexColor, IFormatProvider? provider)
    {
        return value.ToString(provider).Pastel(hexColor);
    }

    /// <summary>
    /// Returns a string wrapped in an ANSI foreground color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="uint"/> value to color.</param>
    /// <param name="hexColor">The color to use on the specified string.<para>Supported format: [#]RRGGBB (case-insensitive).</para></param>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Pastel(this uint value, in ReadOnlySpan<char> hexColor, IFormatProvider? provider)
    {
        return value.ToString(provider).Pastel(hexColor);
    }



    /// <summary>
    /// Returns a string wrapped in an ANSI foreground color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="uint"/> value to color.</param>
    /// <param name="color">The color to use on the specified string.</param>
    /// <param name="format">A standard or custom numeric format string.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Pastel(this uint value, Color color, string? format)
    {
        return value.ToString(format).Pastel(color);
    }

    /// <summary>
    /// Returns a string wrapped in an ANSI foreground color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="uint"/> value to color.</param>
    /// <param name="color">The color to use on the specified string.</param>
    /// <param name="format">A standard or custom numeric format string.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Pastel(this uint value, ConsoleColor color, string? format)
    {
        return value.ToString(format).Pastel(color);
    }

    /// <summary>
    /// Returns a string wrapped in an ANSI foreground color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="uint"/> value to color.</param>
    /// <param name="hexColor">The color to use on the specified string.<para>Supported format: [#]RRGGBB (case-insensitive).</para></param>
    /// <param name="format">A standard or custom numeric format string.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Pastel(this uint value, in string hexColor, string? format)
    {
        return value.ToString(format).Pastel(hexColor);
    }

    /// <summary>
    /// Returns a string wrapped in an ANSI foreground color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="uint"/> value to color.</param>
    /// <param name="hexColor">The color to use on the specified string.<para>Supported format: [#]RRGGBB (case-insensitive).</para></param>
    /// <param name="format">A standard or custom numeric format string.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Pastel(this uint value, in ReadOnlySpan<char> hexColor, string? format)
    {
        return value.ToString(format).Pastel(hexColor);
    }



    /// <summary>
    /// Returns a string wrapped in an ANSI foreground color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="uint"/> value to color.</param>
    /// <param name="color">The color to use on the specified string.</param>
    /// <param name="format">A standard or custom numeric format string.</param>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Pastel(this uint value, Color color, string? format, IFormatProvider? provider)
    {
        return value.ToString(format, provider).Pastel(color);
    }

    /// <summary>
    /// Returns a string wrapped in an ANSI foreground color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="uint"/> value to color.</param>
    /// <param name="color">The color to use on the specified string.</param>
    /// <param name="format">A standard or custom numeric format string.</param>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Pastel(this uint value, ConsoleColor color, string? format, IFormatProvider? provider)
    {
        return value.ToString(format, provider).Pastel(color);
    }

    /// <summary>
    /// Returns a string wrapped in an ANSI foreground color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="uint"/> value to color.</param>
    /// <param name="hexColor">The color to use on the specified string.<para>Supported format: [#]RRGGBB (case-insensitive).</para></param>
    /// <param name="format">A standard or custom numeric format string.</param>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Pastel(this uint value, in string hexColor, string? format, IFormatProvider? provider)
    {
        return value.ToString(format, provider).Pastel(hexColor);
    }

    /// <summary>
    /// Returns a string wrapped in an ANSI foreground color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="uint"/> value to color.</param>
    /// <param name="hexColor">The color to use on the specified string.<para>Supported format: [#]RRGGBB (case-insensitive).</para></param>
    /// <param name="format">A standard or custom numeric format string.</param>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Pastel(this uint value, in ReadOnlySpan<char> hexColor, string? format, IFormatProvider? provider)
    {
        return value.ToString(format, provider).Pastel(hexColor);
    }



    /// <summary>
    /// Returns a string wrapped in an ANSI background color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="uint"/> value to color.</param>
    /// <param name="color">The color to use on the specified string.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string PastelBg(this uint value, Color color)
    {
        return value.ToString().PastelBg(color);
    }

    /// <summary>
    /// Returns a string wrapped in an ANSI background color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="uint"/> value to color.</param>
    /// <param name="color">The color to use on the specified string.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string PastelBg(this uint value, ConsoleColor color)
    {
        return value.ToString().PastelBg(color);
    }

    /// <summary>
    /// Returns a string wrapped in an ANSI background color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="uint"/> value to color.</param>
    /// <param name="hexColor">The color to use on the specified string.<para>Supported format: [#]RRGGBB (case-insensitive).</para></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string PastelBg(this uint value, in string hexColor)
    {
        return value.ToString().PastelBg(hexColor);
    }

    /// <summary>
    /// Returns a string wrapped in an ANSI background color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="uint"/> value to color.</param>
    /// <param name="hexColor">The color to use on the specified string.<para>Supported format: [#]RRGGBB (case-insensitive).</para></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string PastelBg(this uint value, in ReadOnlySpan<char> hexColor)
    {
        return value.ToString().PastelBg(hexColor);
    }



    /// <summary>
    /// Returns a string wrapped in an ANSI background color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="uint"/> value to color.</param>
    /// <param name="color">The color to use on the specified string.</param>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string PastelBg(this uint value, Color color, IFormatProvider? provider)
    {
        return value.ToString(provider).PastelBg(color);
    }

    /// <summary>
    /// Returns a string wrapped in an ANSI background color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="uint"/> value to color.</param>
    /// <param name="color">The color to use on the specified string.</param>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string PastelBg(this uint value, ConsoleColor color, IFormatProvider? provider)
    {
        return value.ToString(provider).PastelBg(color);
    }

    /// <summary>
    /// Returns a string wrapped in an ANSI background color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="uint"/> value to color.</param>
    /// <param name="hexColor">The color to use on the specified string.<para>Supported format: [#]RRGGBB (case-insensitive).</para></param>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string PastelBg(this uint value, in string hexColor, IFormatProvider? provider)
    {
        return value.ToString(provider).PastelBg(hexColor);
    }

    /// <summary>
    /// Returns a string wrapped in an ANSI background color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="uint"/> value to color.</param>
    /// <param name="hexColor">The color to use on the specified string.<para>Supported format: [#]RRGGBB (case-insensitive).</para></param>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string PastelBg(this uint value, in ReadOnlySpan<char> hexColor, IFormatProvider? provider)
    {
        return value.ToString(provider).PastelBg(hexColor);
    }



    /// <summary>
    /// Returns a string wrapped in an ANSI background color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="uint"/> value to color.</param>
    /// <param name="color">The color to use on the specified string.</param>
    /// <param name="format">A standard or custom numeric format string.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string PastelBg(this uint value, Color color, string? format)
    {
        return value.ToString(format).PastelBg(color);
    }

    /// <summary>
    /// Returns a string wrapped in an ANSI background color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="uint"/> value to color.</param>
    /// <param name="color">The color to use on the specified string.</param>
    /// <param name="format">A standard or custom numeric format string.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string PastelBg(this uint value, ConsoleColor color, string? format)
    {
        return value.ToString(format).PastelBg(color);
    }

    /// <summary>
    /// Returns a string wrapped in an ANSI background color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="uint"/> value to color.</param>
    /// <param name="hexColor">The color to use on the specified string.<para>Supported format: [#]RRGGBB (case-insensitive).</para></param>
    /// <param name="format">A standard or custom numeric format string.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string PastelBg(this uint value, in string hexColor, string? format)
    {
        return value.ToString(format).PastelBg(hexColor);
    }

    /// <summary>
    /// Returns a string wrapped in an ANSI background color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="uint"/> value to color.</param>
    /// <param name="hexColor">The color to use on the specified string.<para>Supported format: [#]RRGGBB (case-insensitive).</para></param>
    /// <param name="format">A standard or custom numeric format string.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string PastelBg(this uint value, in ReadOnlySpan<char> hexColor, string? format)
    {
        return value.ToString(format).PastelBg(hexColor);
    }



    /// <summary>
    /// Returns a string wrapped in an ANSI background color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="uint"/> value to color.</param>
    /// <param name="color">The color to use on the specified string.</param>
    /// <param name="format">A standard or custom numeric format string.</param>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string PastelBg(this uint value, Color color, string? format, IFormatProvider? provider)
    {
        return value.ToString(format, provider).PastelBg(color);
    }

    /// <summary>
    /// Returns a string wrapped in an ANSI background color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="uint"/> value to color.</param>
    /// <param name="color">The color to use on the specified string.</param>
    /// <param name="format">A standard or custom numeric format string.</param>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string PastelBg(this uint value, ConsoleColor color, string? format, IFormatProvider? provider)
    {
        return value.ToString(format, provider).PastelBg(color);
    }

    /// <summary>
    /// Returns a string wrapped in an ANSI background color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="uint"/> value to color.</param>
    /// <param name="hexColor">The color to use on the specified string.<para>Supported format: [#]RRGGBB (case-insensitive).</para></param>
    /// <param name="format">A standard or custom numeric format string.</param>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string PastelBg(this uint value, in string hexColor, string? format, IFormatProvider? provider)
    {
        return value.ToString(format, provider).PastelBg(hexColor);
    }

    /// <summary>
    /// Returns a string wrapped in an ANSI background color code using the specified color.
    /// </summary>
    /// <param name="value">The <see cref="uint"/> value to color.</param>
    /// <param name="hexColor">The color to use on the specified string.<para>Supported format: [#]RRGGBB (case-insensitive).</para></param>
    /// <param name="format">A standard or custom numeric format string.</param>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string PastelBg(this uint value, in ReadOnlySpan<char> hexColor, string? format, IFormatProvider? provider)
    {
        return value.ToString(format, provider).PastelBg(hexColor);
    }
}