# The Dancer Kata

Welcome to the **Dancer Kata**! In this exercise, you'll implement a sequence-based algorithm to track the position of a dancer who moves forward and backward following a mathematical rule.

## Problem Statement

The dancer's movements start at position `0` and follow a sequence:
1. **Stage 0**: Initial position is `0`.
2. **Stage 1**: Move `+1` step forward.
3. **Stage 2**: Move `-2` steps backward.
4. **Stage n** (n ≥ 3): The steps are calculated as:
   - **Steps at stage n** = Steps at stage (n-1) - Steps at stage (n-2).

At each stage, you calculate the new position based on the current step and update the dancer's position.

### Example

- `Dancer.GetPositionAt(3)` returns `-4`.
- `Dancer.GetPositionAt(100000)` returns `-5`.
- `Dancer.GetPositionAt(2147483647)` returns `1`.

## Objective

Implement the method:
```csharp
int Dancer.GetPositionAt(int n)