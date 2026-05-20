//https://www.hackerrank.com/challenges/between-two-sets
pub fn get_total_x(a: &[i32], b: &[i32]) -> i32 {
    if a.is_empty() || b.is_empty() {
        return 0;
    }

    let start = *a.iter().max().unwrap_or(&1);
    let end = *b.iter().min().unwrap_or(&100);

    let mut count = 0;

    for x in start..=end {
        let condition1 = a.iter().all(|&el| x % el == 0);
        let condition2 = b.iter().all(|&el| el % x == 0);

        if condition1 && condition2 {
            count += 1;
        }
    }

    count
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn test_between_two_sets() {
        let a = vec![2, 4];
        let b = vec![16, 32, 96];
        assert_eq!(get_total_x(&a, &b), 3);
    }
}