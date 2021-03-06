﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace Shared.Extensions
{
    public static class DisplayAttributeParser
    {
        public static string GetDisplayAttributeValue(this Type t)
        {
            var properties = t.GetProperties();

            if (properties != null)
            {
                var customAttributes = properties
                    .Select(p => p.GetCustomAttribute<DisplayAttribute>())
                    .ToList();

                if (customAttributes != null)
                {
                    var attributeValues = customAttributes
                        .Select(p => p.Name)
                        .ToList();

                    if (attributeValues != null)
                        return string.Join(" ", attributeValues);
                }
            }

            return "";
        }
    }
}
