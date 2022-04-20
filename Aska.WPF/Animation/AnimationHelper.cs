﻿using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Aska.WPF.Animation
{
    public class AnimationHelper
    {
        //缓动动画模型
        public enum EasingFunction
        {
            Back = 0, Bounce = 1, Circle = 2, Cubic = 3, Elastic = 4, Exponential = 5, Power = 6, Quadratic = 7, Quartic = 8, Qudoubleic = 9, Sine = 10
        }

        //静态方法

        /// <summary>
        /// 返回一个创建完毕的ColorAnimation对象
        /// </summary>
        /// <param name="Duration">动画持续时间</param>
        /// <param name="From">动画起始值</param>
        /// <param name="To">动画结束值</param>
        /// <param name="fillBehavior"></param>
        /// <param name="easingFunction"></param>
        /// <param name="mode">缓动动画模板</param>
        /// <param name="em_double">缓动动画扩展浮点参数</param>
        /// <param name="em_int">缓动动画扩展整数参数</param>
        /// <returns></returns>
        public static ColorAnimation CreateAnimation(TimeSpan Duration, Color From, Color To, FillBehavior fillBehavior,
            EasingFunction easingFunction, EasingMode mode, double em_double, int em_int)
        {
            ColorAnimation colorAnimation = new(From, To, Duration, fillBehavior);
            switch (easingFunction)
            {
                case EasingFunction.Back:
                    BackEase backEase = new()
                    {
                        EasingMode = mode,
                        Amplitude = em_double
                    };
                    colorAnimation.EasingFunction = backEase;
                    break;
                case EasingFunction.Bounce:
                    BounceEase bounceEase = new()
                    {
                        EasingMode = mode,
                        Bounces = em_int,
                        Bounciness = em_double
                    };
                    colorAnimation.EasingFunction = bounceEase;
                    break;
                case EasingFunction.Circle:
                    CircleEase circleEase = new()
                    {
                        EasingMode = mode
                    };
                    colorAnimation.EasingFunction = circleEase;
                    break;
                case EasingFunction.Cubic:
                    CubicEase cubicEase = new()
                    {
                        EasingMode = mode
                    };
                    colorAnimation.EasingFunction = cubicEase;
                    break;
                case EasingFunction.Elastic:
                    ElasticEase elasticEase = new()
                    {
                        EasingMode = mode,
                        Oscillations = em_int,
                        Springiness = em_double
                    };
                    colorAnimation.EasingFunction = elasticEase;
                    break;
                case EasingFunction.Exponential:
                    ExponentialEase exponentialEase = new()
                    {
                        EasingMode = mode,
                        Exponent = em_double
                    };
                    colorAnimation.EasingFunction = exponentialEase;
                    break;
                case EasingFunction.Power:
                    PowerEase powerEase = new()
                    {
                        EasingMode = mode,
                        Power = em_double
                    };
                    colorAnimation.EasingFunction = powerEase;
                    break;
                case EasingFunction.Quadratic:
                    QuadraticEase quadraticEase = new()
                    {
                        EasingMode = mode
                    };
                    colorAnimation.EasingFunction = quadraticEase;
                    break;
                case EasingFunction.Quartic:
                    QuarticEase quarticEase = new()
                    {
                        EasingMode = mode
                    };
                    colorAnimation.EasingFunction = quarticEase;
                    break;
                case EasingFunction.Qudoubleic:
                    QuinticEase quinticEase = new()
                    {
                        EasingMode = mode
                    };
                    colorAnimation.EasingFunction = quinticEase;
                    break;
                case EasingFunction.Sine:
                    SineEase sineEase = new()
                    {
                        EasingMode = mode
                    };
                    colorAnimation.EasingFunction = sineEase;
                    break;
            }
            return colorAnimation;
        }

        /// <summary>
        /// 返回一个创建完毕的ThicknessAnimation对象
        /// </summary>
        /// <param name="Duration">动画持续时间</param>
        /// <param name="From">动画起始值</param>
        /// <param name="To">动画结束值</param>
        /// <param name="fillBehavior"></param>
        /// <param name="easingFunction"></param>
        /// <param name="mode">缓动动画模板</param>
        /// <param name="em_double">缓动动画扩展浮点参数</param>
        /// <param name="em_int">缓动动画扩展整数参数</param>
        /// <returns></returns>
        public static ThicknessAnimation CreateAnimation(TimeSpan Duration, Thickness From, Thickness To, FillBehavior fillBehavior,
            EasingFunction easingFunction, EasingMode mode, double em_double, int em_int)
        {
            ThicknessAnimation thicknessAnimation = new(From, To, Duration, fillBehavior);
            switch (easingFunction)
            {
                case EasingFunction.Back:
                    BackEase backEase = new()
                    {
                        EasingMode = mode,
                        Amplitude = em_double
                    };
                    thicknessAnimation.EasingFunction = backEase;
                    break;
                case EasingFunction.Bounce:
                    BounceEase bounceEase = new()
                    {
                        EasingMode = mode,
                        Bounces = em_int,
                        Bounciness = em_double
                    };
                    thicknessAnimation.EasingFunction = bounceEase;
                    break;
                case EasingFunction.Circle:
                    CircleEase circleEase = new()
                    {
                        EasingMode = mode
                    };
                    thicknessAnimation.EasingFunction = circleEase;
                    break;
                case EasingFunction.Cubic:
                    CubicEase cubicEase = new()
                    {
                        EasingMode = mode
                    };
                    thicknessAnimation.EasingFunction = cubicEase;
                    break;
                case EasingFunction.Elastic:
                    ElasticEase elasticEase = new()
                    {
                        EasingMode = mode,
                        Oscillations = em_int,
                        Springiness = em_double
                    };
                    thicknessAnimation.EasingFunction = elasticEase;
                    break;
                case EasingFunction.Exponential:
                    ExponentialEase exponentialEase = new()
                    {
                        EasingMode = mode,
                        Exponent = em_double
                    };
                    thicknessAnimation.EasingFunction = exponentialEase;
                    break;
                case EasingFunction.Power:
                    PowerEase powerEase = new()
                    {
                        EasingMode = mode,
                        Power = em_double
                    };
                    thicknessAnimation.EasingFunction = powerEase;
                    break;
                case EasingFunction.Quadratic:
                    QuadraticEase quadraticEase = new()
                    {
                        EasingMode = mode
                    };
                    thicknessAnimation.EasingFunction = quadraticEase;
                    break;
                case EasingFunction.Quartic:
                    QuarticEase quarticEase = new()
                    {
                        EasingMode = mode
                    };
                    thicknessAnimation.EasingFunction = quarticEase;
                    break;
                case EasingFunction.Qudoubleic:
                    QuinticEase quinticEase = new()
                    {
                        EasingMode = mode
                    };
                    thicknessAnimation.EasingFunction = quinticEase;
                    break;
                case EasingFunction.Sine:
                    SineEase sineEase = new()
                    {
                        EasingMode = mode
                    };
                    thicknessAnimation.EasingFunction = sineEase;
                    break;
            }
            return thicknessAnimation;
        }

        /// <summary>
        /// 返回一个创建完毕的DoubleAnimation对象
        /// </summary>
        /// <param name="Duration">动画持续时间</param>
        /// <param name="From">动画起始值</param>
        /// <param name="To">动画结束值</param>
        /// <param name="fillBehavior"></param>
        /// <param name="easingFunction"></param>
        /// <param name="mode">缓动动画模板</param>
        /// <param name="em_double">缓动动画扩展浮点参数</param>
        /// <param name="em_int">缓动动画扩展整数参数</param>
        /// <returns></returns>
        public static DoubleAnimation CreateAnimation(TimeSpan Duration, double From, double To, FillBehavior fillBehavior,
            EasingFunction easingFunction, EasingMode mode, double em_double, int em_int)
        {
            DoubleAnimation doubleAnimation = new(From, To, Duration, fillBehavior);
            switch (easingFunction)
            {
                case EasingFunction.Back:
                    BackEase backEase = new()
                    {
                        EasingMode = mode,
                        Amplitude = em_double
                    };
                    doubleAnimation.EasingFunction = backEase;
                    break;
                case EasingFunction.Bounce:
                    BounceEase bounceEase = new()
                    {
                        EasingMode = mode,
                        Bounces = em_int,
                        Bounciness = em_double
                    };
                    doubleAnimation.EasingFunction = bounceEase;
                    break;
                case EasingFunction.Circle:
                    CircleEase circleEase = new()
                    {
                        EasingMode = mode
                    };
                    doubleAnimation.EasingFunction = circleEase;
                    break;
                case EasingFunction.Cubic:
                    CubicEase cubicEase = new()
                    {
                        EasingMode = mode
                    };
                    doubleAnimation.EasingFunction = cubicEase;
                    break;
                case EasingFunction.Elastic:
                    ElasticEase elasticEase = new()
                    {
                        EasingMode = mode,
                        Oscillations = em_int,
                        Springiness = em_double
                    };
                    doubleAnimation.EasingFunction = elasticEase;
                    break;
                case EasingFunction.Exponential:
                    ExponentialEase exponentialEase = new()
                    {
                        EasingMode = mode,
                        Exponent = em_double
                    };
                    doubleAnimation.EasingFunction = exponentialEase;
                    break;
                case EasingFunction.Power:
                    PowerEase powerEase = new()
                    {
                        EasingMode = mode,
                        Power = em_double
                    };
                    doubleAnimation.EasingFunction = powerEase;
                    break;
                case EasingFunction.Quadratic:
                    QuadraticEase quadraticEase = new()
                    {
                        EasingMode = mode
                    };
                    doubleAnimation.EasingFunction = quadraticEase;
                    break;
                case EasingFunction.Quartic:
                    QuarticEase quarticEase = new()
                    {
                        EasingMode = mode
                    };
                    doubleAnimation.EasingFunction = quarticEase;
                    break;
                case EasingFunction.Qudoubleic:
                    QuinticEase quinticEase = new()
                    {
                        EasingMode = mode
                    };
                    doubleAnimation.EasingFunction = quinticEase;
                    break;
                case EasingFunction.Sine:
                    SineEase sineEase = new()
                    {
                        EasingMode = mode
                    };
                    doubleAnimation.EasingFunction = sineEase;
                    break;
            }
            return doubleAnimation;
        }
    }
}
