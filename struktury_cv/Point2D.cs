    struct Point2D {
        public int x;
        public int y;
 
        public Point2D(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public int sectiBody() {
            return x + y;
        }
        public int odectiBody() {
            return x - y;
        }
        
        public int vynasobBody() {
            return x * y;
        }

        public int vydelBody() {
            return x / y;
        }

    }