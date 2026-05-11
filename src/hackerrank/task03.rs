pub fn apples_and_oranges(s: i32, t: i32, a: i32, b: i32, apples: &[i32], oranges: &[i32]) {
    let mut apple_count = 0;
    let mut orange_count = 0;

    for i in 0..apples.len() {
        let position = a + apples[i];
        if position >= s && position <= t {
            apple_count += 1;
        }
    }

    for i in 0..oranges.len() {
        let position = b + oranges[i];
        if position >= s && position <= t {
            orange_count += 1;
        }
    }

    println!("{}", apple_count);
    println!("{}", orange_count);
}

#[cfg(test)]
mod tests {
    use super::*; 

    #[test]
    fn check_apples_oranges() {

        apples_and_oranges(7, 11, 5, 15, &[-2, 2, 1], &[5, -6]);
    }
}