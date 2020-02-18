    struct Point2D {
        public int x;
        public int y;
 
        public Point2D(int x, int y) {
            this.x = x;
            this.y = y;
        }

        // vektorove operace
        public Point2D sectiVektory(Point2D vec1, Point2D vec2) {
            Point2D vec3 = new Point2D((vec1.x + vec2.x), (vec1.y + vec2.y));
            return vec3;
        }
        public Point2D vynasobVektory(Point2D vec1, Point2D vec2) {
            Point2D vec3 = new Point2D((vec1.x * vec2.x), (vec1.y * vec2.y));
            return vec3;
        }
        public double skalar(Point2D vec1, Point2D vec2) {
            double skalar = vec1.x * vec2.x + vec1.y * vec2.y;
            return skalar;
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