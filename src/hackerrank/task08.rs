//
use std::collections::HashSet;

pub fn sock_merchant(_n: i32, ar: &[i32]) -> i32 {
    let mut socks_in_drawer = HashSet::new();
    let mut pairs_count = 0;

    for &sock in ar {
        if socks_in_drawer.contains(&sock) {
            socks_in_drawer.remove(&sock); 
            pairs_count += 1;            
        } else {
            socks_in_drawer.insert(sock);
        }
    }

    pairs_count
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn test_sock_merchant() {
        let ar = vec![10, 20, 20, 10, 10, 30, 50, 10, 20];
        assert_eq!(sock_merchant(9, &ar), 3);
    }
}