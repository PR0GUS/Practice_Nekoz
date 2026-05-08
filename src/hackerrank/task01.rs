
pub fn staircase(n: i32) {
    let n = n as usize;
    for i in 1..=n {
        for _ in 0..(n - i) {
            print!(" ");
        }
        for _ in 0..i {
            print!("#");
        }
        println!();
    }
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn test_staircase_output() {
        staircase(4);
    }
}